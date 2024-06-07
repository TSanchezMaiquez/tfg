package com.tfg.usuarios.usuarios.application.service.impl;

import com.tfg.usuarios.usuarios.application.dto.UserDto;
import com.tfg.usuarios.usuarios.application.mapper.UserMapper;
import com.tfg.usuarios.usuarios.application.service.UserService;
import com.tfg.usuarios.usuarios.domain.entity.User;
import com.tfg.usuarios.usuarios.domain.persistence.UserPersistence;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.List;
import java.util.Optional;
import java.util.stream.Collectors;

@Service
public class UserServiceImpl implements UserService {

    private final UserPersistence userPersistence;

    private final UserMapper userMapper;

    public UserServiceImpl(UserPersistence userPersistence, UserMapper userMapper) {
        this.userPersistence = userPersistence;
        this.userMapper = userMapper;
    }

    @Override
    @Transactional(readOnly = true)
    public List<UserDto> getAllUsers() {
        List<User> users = userPersistence.getAllUsers();
        return userMapper.toDto(users);
    }

    @Override
    @Transactional(readOnly = true)
    public Optional<UserDto> getuserByUsername(String username) {
        return userPersistence.getuserByUsername(username).map(userMapper::toDto);
    }

    @Override
    @Transactional
    public UserDto save(UserDto user) {
        return userMapper.toDto(userPersistence.save(userMapper.toEntity(user)));
    }

    @Override
    @Transactional
    public void deleteUser(String username) {
        userPersistence.deleteUser(username);
    }

    @Override
    @Transactional(readOnly = true)
    public List<UserDto> getUsersByCriteria(String filter) {
        List<User> users = this.userPersistence.findAll(filter);
        return users.stream().map(userMapper::toDto).collect(Collectors.toList());
    }
    @Override
    @Transactional
    public UserDto addContact(String username, UserDto contact) {
        UserDto userDto = getuserByUsername(username)
                .orElseThrow(()-> new RuntimeException("usuario no encontrado"));
        UserDto contactoDto = getuserByUsername(contact.getUsername())
                .orElseThrow(()-> new RuntimeException("usuario no encontrado"));
        userDto.getContacts().add(contactoDto.getUsername());

        User user = userPersistence.save(userMapper.toEntity(userDto));

        return userMapper.toDto(user);
    }
    @Transactional
    public void addUserToContact(String username, UserDto contact) {

        UserDto userDto = getuserByUsername(username)
                .orElseThrow(()-> new RuntimeException("usuario no encontrado"));
        UserDto contactoDto = getuserByUsername(contact.getUsername())
                .orElseThrow(()-> new RuntimeException("usuario no encontrado"));
        contactoDto.getContacts().add(userDto.getUsername());

        User user = userPersistence.save(userMapper.toEntity(contactoDto));
    }

}

package com.tfg.usuarios.usuarios.application.service.impl;



import com.tfg.usuarios.usuarios.application.dto.UserDto;
import com.tfg.usuarios.usuarios.application.mapper.UserMapper;
import com.tfg.usuarios.usuarios.application.service.AuthService;
import com.tfg.usuarios.usuarios.domain.entity.User;
import com.tfg.usuarios.usuarios.domain.persistence.UserPersistence;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

import java.util.Optional;

@Service
public class AuthServiceImpl implements AuthService {
    private final UserPersistence userPersistence;
    private final UserMapper userMapper;

    public AuthServiceImpl(UserPersistence userPersistence, UserMapper userMapper) {
        this.userPersistence = userPersistence;
        this.userMapper = userMapper;
    }


    @Override
    @Transactional
    public UserDto register(UserDto userDto) {
        User user = userMapper.toEntity(userDto);
        return userMapper.toDto(userPersistence.save(user));
    }

    @Override
    @Transactional(readOnly = true)
    public Optional<UserDto> getUser(String username) {
        Optional<User> user = userPersistence.getuserByUsername(username);
        if (user.isEmpty()) {
            return Optional.empty();
        }
        return Optional.of(userMapper.toDto(user.get()));
    }
}

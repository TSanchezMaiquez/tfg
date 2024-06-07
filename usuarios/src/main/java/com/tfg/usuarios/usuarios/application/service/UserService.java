package com.tfg.usuarios.usuarios.application.service;

import com.tfg.usuarios.usuarios.application.dto.UserDto;

import java.util.List;
import java.util.Optional;

public interface UserService {
    List<UserDto> getAllUsers();
    Optional<UserDto> getuserByUsername(String username);
    UserDto save(UserDto user);
    void deleteUser(String username);

    List<UserDto> getUsersByCriteria(String filter);

    UserDto addContact(String username, UserDto contact);
    void addUserToContact(String username, UserDto contact);
}

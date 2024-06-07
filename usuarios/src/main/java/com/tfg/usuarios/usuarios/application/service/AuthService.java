package com.tfg.usuarios.usuarios.application.service;





import com.tfg.usuarios.usuarios.application.dto.UserDto;

import java.util.Optional;

public interface AuthService {
    public UserDto register(UserDto userDto);
    Optional<UserDto> getUser(String username);
}

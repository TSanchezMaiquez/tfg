package com.tfg.usuarios.usuarios.application.mapper;

import com.tfg.usuarios.usuarios.application.dto.UserDto;
import com.tfg.usuarios.usuarios.domain.entity.User;
import org.mapstruct.*;

import java.util.ArrayList;
import java.util.HashSet;

@Mapper(componentModel = "spring")
public interface UserMapper extends EntityMapper<UserDto, User> {

    default User fromId(String username) {
        if (username == null) return null;
        User alumno = new User();
        alumno.setUsername(username);
        return alumno;
    }



}

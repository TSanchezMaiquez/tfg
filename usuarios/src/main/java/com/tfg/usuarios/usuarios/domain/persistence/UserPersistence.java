package com.tfg.usuarios.usuarios.domain.persistence;

import com.tfg.usuarios.usuarios.domain.entity.User;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;

import java.util.List;
import java.util.Optional;

public interface UserPersistence {
    List<User> getAllUsers();
    Optional<User> getuserByUsername(String username);
    User save(User user);
    void deleteUser(String username);
    List<User> findAll(String filter);
    //Page<User> findAll(Pageable pageable, String filter);
}

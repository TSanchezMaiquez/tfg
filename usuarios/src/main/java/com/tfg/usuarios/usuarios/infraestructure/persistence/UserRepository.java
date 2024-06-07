package com.tfg.usuarios.usuarios.infraestructure.persistence;

import com.tfg.usuarios.usuarios.domain.entity.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.JpaSpecificationExecutor;

public interface UserRepository extends JpaRepository<User, String>, JpaSpecificationExecutor<User> {
}

package com.tfg.usuarios.usuarios.infraestructure.persistence;

import com.tfg.usuarios.usuarios.domain.entity.Conversacion;
import org.springframework.data.jpa.repository.JpaRepository;

public interface ConversacionRepository extends JpaRepository<Conversacion, Long> {
    Conversacion findByIdentificadorAAndIdentificadorB(Long identificador1, Long identificador2);
}

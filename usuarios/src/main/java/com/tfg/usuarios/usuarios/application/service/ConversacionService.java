package com.tfg.usuarios.usuarios.application.service;

import com.tfg.usuarios.usuarios.application.dto.ConversacionDto;
import com.tfg.usuarios.usuarios.domain.entity.Conversacion;

public interface ConversacionService {
    String getConversacion(Long identificador1, Long identificador2);
    String setConversacion(ConversacionDto conversacion);
}

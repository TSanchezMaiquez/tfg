package com.tfg.usuarios.usuarios.domain.persistence;

import com.tfg.usuarios.usuarios.domain.entity.Conversacion;

public interface ConversacionPersistence {

    String getConversacion(Long identificador1, Long identificador2);
    String setConversacion(Conversacion conversacion);
}

package com.tfg.usuarios.usuarios.application.service.impl;

import com.tfg.usuarios.usuarios.application.dto.ConversacionDto;
import com.tfg.usuarios.usuarios.application.mapper.ConversacionMapper;
import com.tfg.usuarios.usuarios.application.service.ConversacionService;
import com.tfg.usuarios.usuarios.domain.persistence.ConversacionPersistence;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

@Service
public class ConversacionServiceImp implements ConversacionService {
    private final ConversacionPersistence conversacionPersistence;
    private final ConversacionMapper conversacionMapper;

    public ConversacionServiceImp(ConversacionPersistence conversacionPersistence, ConversacionMapper conversacionMapper) {
        this.conversacionPersistence = conversacionPersistence;
        this.conversacionMapper = conversacionMapper;
    }

    @Override
    @Transactional(readOnly = true)
    public String getConversacion(Long identificador1, Long identificador2) {
        String conversacion = conversacionPersistence.getConversacion(identificador1, identificador2);

        if (conversacion == null || conversacion.length() == 0) {
            conversacion = conversacionPersistence.getConversacion(identificador2, identificador1);
        }

        return conversacion != null ? conversacion : "";
    }

    @Override
    @Transactional
    public String setConversacion(ConversacionDto conversacion) {
        return conversacionPersistence.setConversacion(conversacionMapper.toEntity(conversacion));
    }
}

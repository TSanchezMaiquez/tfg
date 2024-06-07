package com.tfg.usuarios.usuarios.infraestructure.persistence;

import com.tfg.usuarios.usuarios.domain.entity.Conversacion;
import com.tfg.usuarios.usuarios.domain.persistence.ConversacionPersistence;
import org.springframework.stereotype.Repository;

@Repository
public class ConversacionPersistenceImpl implements ConversacionPersistence {
    private final ConversacionRepository conversacionRepository;

    public ConversacionPersistenceImpl(ConversacionRepository conversacionRepository) {
        this.conversacionRepository = conversacionRepository;
    }

    @Override
    public String getConversacion(Long identificador1, Long identificador2) {
        Conversacion conversacion = conversacionRepository
                .findByIdentificadorAAndIdentificadorB(identificador1, identificador2);
        if (conversacion != null) {
            return conversacion.getConversacion();
        } else {
            return null;
        }
    }

    @Override
    public String setConversacion(Conversacion conversacion) {
        conversacionRepository.save(conversacion);
        return conversacion.getConversacion();
    }
}

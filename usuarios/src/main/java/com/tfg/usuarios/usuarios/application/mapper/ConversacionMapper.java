package com.tfg.usuarios.usuarios.application.mapper;

import com.tfg.usuarios.usuarios.application.dto.ConversacionDto;
import com.tfg.usuarios.usuarios.domain.entity.Conversacion;
import org.mapstruct.Mapper;

@Mapper(componentModel = "spring")
public interface ConversacionMapper extends EntityMapper<ConversacionDto, Conversacion>{


    default Conversacion fromId(Long id){
        if (id == null) return null;
        Conversacion conversacion = new Conversacion();
        conversacion.setId(id);
        return conversacion;

    }
}

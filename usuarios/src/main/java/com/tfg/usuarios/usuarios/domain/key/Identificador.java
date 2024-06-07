package com.tfg.usuarios.usuarios.domain.key;

import jakarta.persistence.Column;
import jakarta.persistence.Embeddable;

import java.io.Serializable;

@Embeddable
public class Identificador implements Serializable {

    @Column(name = "usuarioA")
    private Long primerId;

    @Column(name = "usuarioB")
    private Long segundoId;

    public Long getPrimerId() {
        return primerId;
    }

    public void setPrimerId(Long primerId) {
        this.primerId = primerId;
    }

    public Long getSegundoId() {
        return segundoId;
    }

    public void setSegundoId(Long segundoId) {
        this.segundoId = segundoId;
    }
}

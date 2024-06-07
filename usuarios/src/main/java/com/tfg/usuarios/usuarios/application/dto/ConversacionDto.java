package com.tfg.usuarios.usuarios.application.dto;


import java.io.Serializable;

public class ConversacionDto implements Serializable {
    private Long id;
    private Long identificadorA;
    private Long identificadorB;

    private String conversacion;

    public ConversacionDto() {
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
    }

    public Long getIdentificadorA() {
        return identificadorA;
    }

    public void setIdentificadorA(Long identificadorA) {
        this.identificadorA = identificadorA;
    }

    public Long getIdentificadorB() {
        return identificadorB;
    }

    public void setIdentificadorB(Long identificadorB) {
        this.identificadorB = identificadorB;
    }

    public String getConversacion() {
        return conversacion;
    }

    public void setConversacion(String conversacion) {
        this.conversacion = conversacion;
    }
}

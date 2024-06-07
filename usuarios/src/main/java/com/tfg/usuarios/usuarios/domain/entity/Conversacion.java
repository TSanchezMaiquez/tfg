package com.tfg.usuarios.usuarios.domain.entity;


import jakarta.persistence.*;

@Entity
@Table(name = "conversaciones")
public class Conversacion {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    @Column(name = "usuario A")
    private Long identificadorA;
    @Column(name = "usuario B")
    private Long identificadorB;
    @Lob
    private String conversacion;

    public Long getIdentificadorA() {
        return identificadorA;
    }

    public Long getId() {
        return id;
    }

    public void setId(Long id) {
        this.id = id;
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

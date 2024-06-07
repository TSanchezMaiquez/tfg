package com.tfg.usuarios.usuarios.application.dto;

public class LoginDto {
    private String username;
    private String password;

    public LoginDto() {
    }

    public LoginDto(String username, String password) {
        this.username = username;
        this.password = password;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String nombreDeUsuario) {
        this.username = nombreDeUsuario;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}

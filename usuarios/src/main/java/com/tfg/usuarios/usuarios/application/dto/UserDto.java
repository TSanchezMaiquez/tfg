package com.tfg.usuarios.usuarios.application.dto;

import com.tfg.usuarios.usuarios.domain.type.UserRol;

import java.io.Serializable;
import java.util.List;

public class UserDto implements Serializable {
    private String username;
    private String password;
    private String secondname;
    private String email;
    private UserRol userRol;
    private Double salary;
    private List<String> contacts;
    private Long numIdent;

    private byte[] imagen;

    public UserDto() {
    }

    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }

    public Long getNumIdent() {
        return numIdent;
    }

    public void setNumIdent(Long numIdent) {
        this.numIdent = numIdent;
    }

    public List<String> getContacts() {
        return contacts;
    }

    public void setContacts(List<String> contacts) {
        this.contacts = contacts;
    }

    public String getUsername() {
        return username;
    }

    public void setUsername(String username) {
        this.username = username;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public String getSecondname() {
        return secondname;
    }

    public void setSecondname(String secondname) {
        this.secondname = secondname;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public UserRol getUserRol() {
        return userRol;
    }

    public void setUserRol(UserRol userRol) {
        this.userRol = userRol;
    }

    public Double getSalary() {
        return salary;
    }

    public void setSalary(Double salary) {
        this.salary = salary;
    }
}

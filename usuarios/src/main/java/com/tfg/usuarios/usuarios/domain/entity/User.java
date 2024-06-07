package com.tfg.usuarios.usuarios.domain.entity;

import com.tfg.usuarios.usuarios.domain.type.UserRol;
import jakarta.persistence.*;
import jakarta.validation.constraints.Positive;
import jakarta.validation.constraints.Size;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;
import java.util.Set;

@Entity
@Table(name = "usuarios")
public class User {

    @Id
    @Column(name = "nombre", nullable = false)
    private String username;
    @Column(length =255, nullable = false)
    private String password;

    @Column(name = "apellidos", nullable = false)
    @Size(min = 3, max = 100)
    private String secondname;

    @Column(name = "email", nullable = false)
    @Size(min = 3, max = 100)
    private String email;

    @Column(name = "rol_usuario", nullable = false, length = 20)
    @Enumerated(EnumType.STRING)
    private UserRol userRol;

    @Column(nullable = false, name = "sueldo")
    @Positive
    private Double salary;
    @Column(name = "num_ident", nullable = false, unique = true)
    private Long numIdent;
    @Lob
    private byte[] imagen;

    @ElementCollection
    @CollectionTable(name = "Contactos",
            joinColumns = @JoinColumn(name = "usuario") )
    @Column(name = "contacto")
    private List<String> contacts = new ArrayList<>();


    public List<String> getContacts() {
        return contacts;
    }

    public void setContacts(List<String> contacts) {
        this.contacts = contacts;
    }

    public Long getNumIdent() {
        return numIdent;
    }

    public void setNumIdent(Long numIdent) {
        this.numIdent = numIdent;
    }


    public String getUsername() {
    return username;
    }

    public void setUsername(String firstname) {
    this.username = firstname;
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

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }

    public byte[] getImagen() {
        return imagen;
    }

    public void setImagen(byte[] imagen) {
        this.imagen = imagen;
    }

    @Override
    public boolean equals(Object o) {
        if (this == o) return true;
        if (!(o instanceof User user)) return false;
        return Objects.equals(username, user.username) && Objects.equals(password, user.password) && Objects.equals(secondname, user.secondname) && Objects.equals(email, user.email) && userRol == user.userRol && Objects.equals(salary, user.salary);
    }

    @Override
    public int hashCode() {
        return Objects.hash(username, password, secondname, email, userRol, salary);
    }

    @Override
    public String toString() {
        return "User{" +
                "username='" + username + '\'' +
                ", password='" + password + '\'' +
                ", secondname='" + secondname + '\'' +
                ", email='" + email + '\'' +
                ", userRol=" + userRol +
                ", salary=" + salary +
                '}';
    }
}

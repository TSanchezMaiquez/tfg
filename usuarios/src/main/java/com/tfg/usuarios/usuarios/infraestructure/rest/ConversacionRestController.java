package com.tfg.usuarios.usuarios.infraestructure.rest;

import com.tfg.usuarios.usuarios.application.dto.ConversacionDto;
import com.tfg.usuarios.usuarios.application.dto.UserDto;
import com.tfg.usuarios.usuarios.application.service.ConversacionService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.Optional;

@RestController
public class ConversacionRestController {
    private final ConversacionService conversacionService;

    public ConversacionRestController(ConversacionService conversacionService) {
        this.conversacionService = conversacionService;
    }

    @GetMapping(value = "/conversacion/{identificadorA}/{identificadorB}", produces = "application/json")
    public ResponseEntity<String> getconversacion(@PathVariable Long identificadorA,
                                                  @PathVariable Long identificadorB){
        String conversacion = conversacionService.getConversacion(identificadorA, identificadorB);

        return new ResponseEntity<>(conversacion, HttpStatus.OK);

    }

    @PostMapping(value = "/conversacion", produces = "application/json")
    public ResponseEntity<String> insertConversacion(@RequestBody ConversacionDto conversacionDto) {
        String conversacion = conversacionService.setConversacion(conversacionDto);
        return new ResponseEntity<>(conversacion, HttpStatus.CREATED);
    }
}

package com.tfg.usuarios.usuarios.infraestructure.rest;

import com.tfg.usuarios.usuarios.application.dto.UserDto;
import com.tfg.usuarios.usuarios.application.service.UserService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.Authentication;
import org.springframework.security.core.context.SecurityContextHolder;
import org.springframework.web.bind.annotation.*;

import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.Optional;

@RestController
public class UserRestController {

    private final UserService userService;

    public UserRestController(UserService userService) {
        this.userService = userService;
    }

    @GetMapping(value = "/whoami") public Map<String, String> whoami(){
        Map<String, String> response = new HashMap<>();
        Authentication authentication = SecurityContextHolder.getContext().getAuthentication();
        String userId= authentication.getName();

        response.put("nombreDeUsuario", userId);
        return response;
    }
    @GetMapping(value = "/users/{username}", produces = "application/json")
    public ResponseEntity<UserDto> getUserById(@PathVariable String username){
        Optional<UserDto>  user = userService.getuserByUsername(username);
        if(user.isPresent()){
            return new ResponseEntity<>(user.get(), HttpStatus.OK);
        }else{
            return new ResponseEntity<>(HttpStatus.NOT_FOUND);
        }
    }
    @PostMapping(value = "/users", produces = "application/json")
    public ResponseEntity<UserDto> insertUser(@RequestBody UserDto userDto) {
        userDto = userService.save(userDto);
        return new ResponseEntity<>(userDto, HttpStatus.CREATED);
    }
    @PatchMapping(value = "/users/{username}", produces = "application/json", consumes = "application/json")
    public ResponseEntity<UserDto> updateUser(@PathVariable String username, @RequestBody UserDto userDto) {
        userDto = userService.save(userDto);
        return new ResponseEntity<>(userDto, HttpStatus.OK);
    }
    @DeleteMapping(value = "/users/{username}")
    public ResponseEntity<Void> deleteUser(@PathVariable String username) {
        userService.deleteUser(username);
        return new ResponseEntity<>(HttpStatus.OK);
    }

    @GetMapping(value = "/users", produces = "application/json")
    public ResponseEntity<List<UserDto>> getUsersByCriteria(
            @RequestParam(value = "filter", required = false) String filter) {
        List<UserDto> users = userService.getUsersByCriteria(filter);
        return new ResponseEntity<>(users, HttpStatus.OK);
    }
    @PostMapping(value = "/users/{username}", produces = "application/json")
    public ResponseEntity<UserDto> addContactToUser(@PathVariable String username, @RequestBody UserDto contact) {
        UserDto userDto = userService.addContact(username, contact);
        userService.addUserToContact(username, contact);
        return new ResponseEntity<>(userDto, HttpStatus.CREATED);
    }
}

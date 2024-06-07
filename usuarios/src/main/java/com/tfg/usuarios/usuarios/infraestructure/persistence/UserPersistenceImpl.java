package com.tfg.usuarios.usuarios.infraestructure.persistence;

import com.tfg.usuarios.usuarios.domain.entity.User;
import com.tfg.usuarios.usuarios.domain.persistence.UserPersistence;
import com.tfg.usuarios.usuarios.specs.UserSpecification;
import com.tfg.usuarios.usuarios.specs.shared.SearchCriteriaHelper;
import org.springframework.data.domain.Page;
import org.springframework.data.domain.Pageable;
import org.springframework.stereotype.Repository;

import java.util.List;
import java.util.Optional;

@Repository
public class UserPersistenceImpl implements UserPersistence {

    private final UserRepository userRepository;

    public UserPersistenceImpl(UserRepository userRepository) {
        this.userRepository = userRepository;
    }

    @Override
    public List<User> getAllUsers() {
        return userRepository.findAll();
    }

    @Override
    public Optional<User> getuserByUsername(String username) {
        return userRepository.findById(username);
    }

    @Override
    public User save(User user) {
        return userRepository.save(user);
    }

    @Override
    public void deleteUser(String username) {
        userRepository.deleteById(username);
    }

   /* @Override
    public Page<User> findAll(Pageable pageable, String filter) {
        UserSpecification specification = new UserSpecification(SearchCriteriaHelper.fromFilterString(filter));
        return userRepository.findAll(specification, pageable);
    }*/

    @Override
    public List<User> findAll(String filter) {
        UserSpecification specification = new UserSpecification(SearchCriteriaHelper.fromFilterString(filter));
        return userRepository.findAll(specification);
    }
}

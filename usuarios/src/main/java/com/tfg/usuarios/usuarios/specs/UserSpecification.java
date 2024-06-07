package com.tfg.usuarios.usuarios.specs;



import com.tfg.usuarios.usuarios.domain.entity.User;
import com.tfg.usuarios.usuarios.specs.shared.EntitySpecification;
import com.tfg.usuarios.usuarios.specs.shared.SearchCriteria;
import org.springframework.data.jpa.domain.Specification;

import java.util.List;

public class UserSpecification extends EntitySpecification<User> implements Specification<User> {


    public UserSpecification(List<SearchCriteria> criteria) {
        this.criteria = criteria;
    }



}

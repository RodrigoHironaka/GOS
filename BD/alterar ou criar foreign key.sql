ALTER TABLE cliente
ADD CONSTRAINT FK_Dep FOREIGN KEY (idDepartamento) REFERENCES departamento (id);
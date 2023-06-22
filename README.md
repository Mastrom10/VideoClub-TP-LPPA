# VideoClub - Aplicación CRUD en ASP.NET Core

## Acerca del Proyecto

El presente proyecto representa una implementación de un sistema CRUD (Create, Read, Update, Delete) para el manejo de películas en un videoclub, desarrollado en ASP.NET Core con el patrón Modelo-Vista-Controlador (MVC).

Para llevar a cabo este proyecto, se seleccionó la entidad "Pelicula" y se desarrolló un modelo para la misma, así como las controladoras y vistas necesarias para manejar las operaciones CRUD en torno a esta entidad. La entidad "Pelicula" tiene campos que permiten almacenar la información más relevante, como el título, director, género, fecha de lanzamiento y la disponibilidad de la película.

Se ha creado una estructura de directorios que sigue el patrón MVC. El modelo se encuentra en la carpeta "Models", las vistas en "Views" y los controladores en "Controllers". Además, se tiene una carpeta "Data" que contiene el código para interactuar con la base de datos. Para cada operación CRUD, se han creado vistas y métodos correspondientes en la controladora.

El archivo 'CrearBaseDeDatos.sql' en la carpeta 'Data' contiene el script SQL para crear la base de datos y la tabla 'Peliculas'.

## Autor

Mi nombre es Nicolas Mastromarino. Actualmente estoy cursando el 4to año de la carrera de Ingeniería en Sistemas en la UAI, sede Castelar. El código de la materia para la que se desarrolló este trabajo es T1-09-37, "LENGUAJES DE PROGRAMACIÓN PARA LA ADMINISTRACIÓN".

## Enlace al repositorio de GitHub

Puedes encontrar el código fuente de este proyecto en mi [repositorio de GitHub](https://github.com/Mastrom10/VideoClub-TP-LPPA).

## Consideraciones Finales

Este proyecto es una representación básica de cómo una aplicación CRUD puede ser implementada utilizando ASP.NET Core MVC. Aunque es simple en su funcionalidad, sirve como una sólida base sobre la cual se pueden desarrollar características adicionales y mayor funcionalidad para un sistema de videoclub más completo.

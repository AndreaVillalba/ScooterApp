# ScooterApp
Aplicación web en c# encargada de controlar los alquileres y devoluciones de scooters en diferentes estaciones

La aplicacin considera una arquitectura multicapa: persistencia, logica, presentacion

Para conseguir la capa de **persistencia**: *ClassLibrary/Persistencia*
Para conseguir la capa de **logica**: *ClassLibrary/BusinessLogic*
Para conseguir la capa de **presentacion**: *EcoScooterGUI*

Para persistir los datos se utilizo EntityFramework y DBContext cuya implementacion se puede ver en la carpeta de *ClassLibrary/Persistencia*

La conexion entre la capa logica y la de presentacion se realizo en la clase llamada **EcoScooterService y IEcoScooterService**, la cual esta localizada en: *ClassLibrary/BusinessLogic/Services*

Adicionalmente las otras carpetas se utilizaron para realizarle diversas pruebas a las capas mencionadas previamente, para comprbar la prevencion de errores y el cumplimiento de los casos de uso.


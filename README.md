# ScooterApp
Aplicación web en c# encargada de controlar los alquileres y devoluciones de scooters en diferentes estaciones.

La aplicación esta hecha mateniendo la separación de capas: persistencia, lógica, presentación.

- Para conseguir la capa de **persistencia**: *ClassLibrary/Persistencia*
- Para conseguir la capa de **lógica**: *ClassLibrary/BusinessLogic*
- Para conseguir la capa de **presentación**: *EcoScooterGUI*

Para persistir los datos se utilizó EntityFramework y DBContext cuya implementación se puede ver en la carpeta de *ClassLibrary/Persistencia*.

La conexión entre la capa logica y la de presentación se realizó en la clase llamada **EcoScooterService y IEcoScooterService**, la cual está localizada en: *ClassLibrary/BusinessLogic/Services*.

Adicionalmente las otras carpetas se utilizaron para realizarle diversas pruebas a las capas mencionadas previamente, para comprobar la prevención de errores y el cumplimiento de los casos de uso.


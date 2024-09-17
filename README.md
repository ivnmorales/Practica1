# Practica1
#Morales Salgado Ivan Andres
#Martinez Zuluaga Daniela

Practica 1- ALQUILER DE VEHICULOS(Grupo 580304006-1)

#Instrucciones para el Uso del Sistema de Alquiler de Vehículos
#Descripción
Este sistema permite la gestión y alquiler de vehículos. Los usuarios pueden iniciar sesión como administradores o clientes para acceder a diferentes funcionalidades.
#Funcionalidades

#Como Administrador:
Registrar Vehículo: Añadir nuevos vehículos al sistema (automóviles, motocicletas o camiones).
Eliminar Vehículo: Eliminar vehículos existentes.
Actualizar Vehículo: Modificar detalles de un vehículo, como el precio de alquiler.
Ver Historial de Reservas: Consultar el historial de reservas de todos los vehículos.
Mostrar Vehículos: Listar todos los vehículos registrados.
Cambiar a Cliente: Cambiar el rol de administrador a cliente.

#Como Cliente:
Reservar Vehículo: Reservar un vehículo disponible.
Devolver Vehículo: Devolver un vehículo alquilado.
Mostrar Vehículos: Ver todos los vehículos disponibles.
Cambiar a Administrador: Cambiar el rol de cliente a administrador.

#Estructura del Proyecto
Alquiler: Contiene la clase principal Alquiler que gestiona la lógica de la aplicación.
Vehiculo y sus derivados (Automovil, Motocicleta, Camion): Definen las características y comportamientos específicos de cada tipo de vehículo.
EstadoVehiculo: Enumeración para los estados posibles de un vehículo.
IVehiculo: Interfaz que define los métodos necesarios para los vehículos.

#Notas Importantes
Rol del Usuario: El sistema distingue entre Administrador y Cliente. 
Tipo de Vehículo: Cuando se registre un nuevo vehículo, selecciona el tipo (Automovil, Motocicleta o Camion) para que se registre correctamente.
Historial de Reservas: El historial se actualiza cada vez que se realiza una reserva o alquiler.

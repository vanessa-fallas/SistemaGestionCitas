# Manual de Usuario
# Sistema de Gestión de Citas

# 1. Introducción

El Sistema de Gestión de Citas es una aplicación de escritorio desarrollada en C# que permite administrar clientes, servicios y citas. Este manual explica las principales funciones y cómo utilizarlas.

# 2. Inicio del sistema

Para iniciar el sistema, se debe ejecutar la aplicación desde Visual Studio o mediante su archivo ejecutable. Al abrirse, se muestra la ventana principal con las opciones de navegación.

# 3. Menú principal

El menú permite acceder a las diferentes funciones del sistema:

- Registrar clientes: permite agregar nuevos clientes.
- Registrar servicios: permite registrar servicios y consultar los existentes.
- Citas: permite administrar las citas.
- Salir: cierra la aplicación.

# 4. Registro de clientes y servicios

Clientes: ingresar la cédula, nombre completo y teléfono en los campos correspondientes y presionar "Registrar". Los clientes registrados se muestran en una tabla.

Servicios: ingresar el nombre, precio y duración en minutos. También se debe indicar si el servicio está disponible y presionar "Guardar". Los servicios registrados aparecen en una tabla junto con sus datos y disponibilidad.

# 5. Gestión de citas

Desde la opción "Citas" se pueden realizar las siguientes operaciones:

- Registrar: seleccionar un cliente, un servicio, una fecha y una hora, y presionar "Registrar".
- Consultar: permite visualizar las citas registradas y filtrar las citas por cliente, servicio y fecha.
- Modificar: seleccionar una cita, cambiar sus datos y presionar "Guardar cambios".
- Cancelar: seleccionar la cita deseada y presionar "Cancelar cita" para eliminarla del registro.

# 6. Validaciones

El sistema comprueba que los campos obligatorios estén completos y que los datos tengan el formato esperado.

- La cédula y el teléfono deben contener números.
- El nombre del cliente no puede estar vacío.
- El nombre del servicio es obligatorio y no puede repetirse.
- El precio debe ser numérico y no negativo.
- La duración debe ser un número entero mayor que cero.
- Para registrar una cita se debe seleccionar un cliente y un servicio.

# 7. Mensajes del sistema

El sistema muestra mensajes para informar sobre las operaciones realizadas, por ejemplo, cuando un cliente, servicio o cita se registra correctamente, cuando una cita se modifica o cancela y cuando no se encuentran resultados o existen datos incorrectos.

### 8. Cierre del sistema

Para cerrar la aplicación, seleccionar la opción "Salir" del menú principal.



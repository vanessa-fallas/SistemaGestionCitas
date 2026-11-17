# Manual Técnico
# Sistema de Gestión de Citas

# 1. Tecnologías

El proyecto fue desarrollado utilizando las siguientes tecnologías:

- C#: lenguaje de programación utilizado para desarrollar la lógica del sistema.
- Windows Forms: tecnología utilizada para crear la interfaz gráfica.
- Visual Studio: entorno de desarrollo utilizado para programar y ejecutar la aplicación.
- Git y GitHub: herramientas utilizadas para el control de versiones y el trabajo colaborativo.

# 2. Estructura del proyecto

El proyecto está organizado principalmente en los siguientes archivos:

- FormPrincipal.cs: contiene la lógica para registrar y consultar clientes y servicios, además de controlar la navegación principal.
- FormPrincipal.Designer.cs: contiene la configuración y diseño visual de la ventana principal.
- FormCitas.cs: contiene la lógica para registrar, consultar, modificar y cancelar citas.
- FormCitas.Designer.cs: contiene el diseño visual de la ventana de gestión de citas.

# 3. Flujo de la aplicación

Al ejecutar el programa, se muestra el formulario principal. Desde este se puede acceder a la gestión de clientes, servicios y citas. Al seleccionar la opción de citas, se abre un segundo formulario donde se realizan las operaciones correspondientes.

# 4. Formularios principales

- FormPrincipal: administra los clientes y servicios, además de permitir la navegación hacia las citas.
- FormCitas: permite realizar las operaciones de registro, consulta, modificación y cancelación de citas.

# 5. Métodos principales

Entre los principales métodos implementados se encuentran:

- btnRegistrar_Click(): registra nuevos clientes.
- btnGuardar_Click(): registra nuevos servicios.
- ActualizarContadores(): actualiza la cantidad total de servicios y los disponibles.
- CargarCitas(): muestra las citas registradas.
- CargarFiltros(): carga las opciones de filtrado de citas.
- btnConsultaBuscar_Click(): realiza la búsqueda de citas.
- btnGuardarCambios_Click(): modifica una cita existente.
- btnCancelarCita_Click(): cancela una cita seleccionada.

# 6. Listas o colecciones

El sistema utiliza listas genéricas (List<string[]>) para almacenar temporalmente la información:

- LClientes: almacena los datos de los clientes.
- LServicios: almacena los datos de los servicios.
- LCitas: almacena los datos de las citas.

Cada elemento de las listas es un arreglo de cadenas (string[]) que contiene los datos correspondientes a cada registro.

# 7. Validaciones

Se utilizan condiciones y métodos como int.TryParse() y decimal.TryParse() para comprobar que los datos ingresados sean correctos.

También se valida que los campos obligatorios no estén vacíos, que no se repitan los nombres de los servicios y que se seleccione un cliente y un servicio al registrar una cita.

# 8. Manejo de errores

El sistema utiliza mensajes mediante MessageBox.Show() para informar al usuario cuando los datos ingresados no son válidos, cuando no se encuentran resultados o cuando falta seleccionar información necesaria.

# 9. Organización del código

El código se organiza mediante formularios, métodos y eventos asociados a los controles de la interfaz gráfica. Se utilizan listas para almacenar los registros y métodos independientes para realizar operaciones específicas, facilitando la lectura y el mantenimiento del programa.

# 10. Uso de Git y GitHub

Se utiliza Git para llevar el control de versiones del proyecto y GitHub como repositorio remoto para almacenar y compartir el código.


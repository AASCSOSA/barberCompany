# BarberShop Application

Este proyecto es una aplicación de gestión para una barbería. Permite llevar un control de citas, clientes, servicios, y empleados, entre otros.

## Requisitos previos

Antes de comenzar, asegúrate de que tienes lo siguiente instalado en tu máquina:

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)
- [SQL Server](https://www.microsoft.com/en-us/sql-server)
- [.NET Core SDK](https://dotnet.microsoft.com/download)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)

##Base de datos
La base de datos se encuentra lista en la carpeta Bd

## Configuración del proyecto

### Clonar el repositorio

Clona este repositorio en tu máquina local ejecutando el siguiente comando en tu terminal o línea de comandos:

```bash
git clone https://github.com/AASCSOSA/barberCompany.git
```

### Configuración de la base de datos

Este proyecto utiliza una base de datos SQL Server. Si la base de datos es actualizada o no te permite acceder, deberás regenerar los modelos de la base de datos en el proyecto.

Ejecuta el siguiente comando en Visual Studio 2022 para hacer un scaffolding de la base de datos y generar las clases de modelo:

```bash
Scaffold-DbContext "Server=localhost;Database=barberShop;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
```

Si el comando anterior no funciona, utiliza esta variante para conectarte a una instancia de SQL Server Express:

```bash
Scaffold-DbContext "Server=localhost\SQLEXPRESS;Database=barberShop;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Force
```

Este comando genera automáticamente las clases de modelo en la carpeta `Models` del proyecto y sobrescribe los archivos existentes.

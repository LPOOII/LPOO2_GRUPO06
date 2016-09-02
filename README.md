#Laboratorio de programación orientada a objetos II

## Grupo 6

Este repositorio corresponde al grupo 6, de la materia Laboratorio de programación orientada a objetos 2 del año 2016.

## Profesores

+ Aragón Fabiana
+ Sixto Alberto


## Integrantes

+ Escalera Walter
+ Ibañez Alejandro
+ Galdo Sandoval Paulo Antonio
+ Perez Gabriel
+ Sajama Maxi
+ Sosa Raul
+ Tejerina Eduardo


# Como empezar

## Descargar e instalar git

Entrar a la pagina de [Git](https://git-scm.com/downloads) y bajar la version para Windows 2.9.3

### Pasos para instalar.

+ En "Select components" dejar tal cual.
+ En "Adjusting your PATH enviroment" marcar la segunda opcion "Use git from the Windows Command Prompt".
+ En "Configuring the line ending conversions" dejar tal cual.
+ Finalizar la instalación.
+ Abrir la consola de comandos de windows (cmd) y escribir ```git --version``` para comprobar su correcta instalación.

#### Para los usuarios de Windows 10 posiblemente deban agregar el PATH para git.

+ Sistema > Configuración avanzada del sistema > Opciones avanzadas > Variables de entorno
+ Buscar en el dialogo de "Variables del sistema" la variable de nombre "Path"
+ Agregar un ; (punto y coma) al final del texto
+ Agregar la ruta al executable de git, por ejemplo ```C:\Program Files (x86)\Git\cmd```
+ Aceptar y cerrar todo
+ Abrir la consola de comandos de windows (cmd) y escribir ```git --version``` para comprobar su correcta instalación.

#### Instalamos las herramientas para trabajar desde Visual Studio 2010

+ Instalar [Git Extensions](http://gitextensions.github.io/) de forma normal.
+ Abrir Visual Studio
+ En la barra de opciones ir a Herramientas > Administrar Extensiones > Galeria en linea
+ Buscar la extension Git Source Control Provider e instalar.
+ Se reiniciara Visual Studio
+ En la barra de opciones ir a Herramientas > Opciones
+ En el panel izquierdo navegar hasta "Source Control"
+ En "Selección de complemento" elegir Git Source Control Provider.
+ Luego en la opciones de abajo "Git Source Control Provider Options" Agregar el Path para Git Extensions por ejemplo ``` C:\Program Files (x86)\GitExtensions\GitExtensions.exe```
+ Marcar la casilla de "Use TortoiseGit style icon set".
+ Aceptar y se reiniciara Visual Studio.


## Como bajar y empezar a usar este repositorio.

+ Abran la consola de comandos de Windows (cmd) y navegen hasta la carpeta donde guarden sus projectos.
+ Clonamos el repositorio con el siguiente comando ```git clone https://github.com/LPOOII/LPOO2_GRUPO06.git```
+ Abrimos normalmente el proyecto en Visual Studio.



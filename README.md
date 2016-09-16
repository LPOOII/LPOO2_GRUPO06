#Como usar git

## Hacer un pull (Descargar del repositorio los cambios).

+ Para hacer un pull desde el gitExtensions u otro herramienta deben buscar la opcion de pull.
+ Si usan el cmd, podran hacerlo desde la carpeta del proyecto con el comando ```git pull origin```

### Que hacer si me da error ?

Pueden hacer dos cosas:

+ Hacer un stash desde su herramienta o desde la consola con ```git stash```. Esto eliminara sus cambios y regresara el repositorio al punto en el que lo descargaron. (Usenlo con cuidado)
+ Hacer commit y luego un merge. Esto se los recomiendo hacerlo desde el gitExtension, porque al tener el commit hecho e intentar hacer un pull les mostrara una herramienta para solucionar conflictos y se les sera mas facil elegir que cambios conservar. (Usenlo con cuidado de no reemplazar algo que no deban en el repositorio)

## Hacer un push (Subir cambios al repositorio).

+ Primero deben agregar que archivos van a cambiar usando el add en sus herramientas o por comando con ```git add <Nombre_archivo>```
+ Seguido de esto deberan hacer un commit el cual va sobre los archivos que se incluyen en el add.
+ Deberan escribir un comentario relatando que tipos de cambios hicieron. 
+ Pueden hacer esto con el comando ```git commit -m "mi mensaje"```
+ Luego de tener todos nuestros archivos preparados para subir en la herramienta que usen hagan push o por comando ```git push origin```

### Que hacer si me da error?

Para resolver esto deberan hacer un merge. En donde deberan elegir que archivos cambiaran y cuales no. Insisto esto es mas facil desde el gitExtensions puesto que su herramienta para conflictos permite decidir que cambios reealizar.


## A que se deben los errores?

El error se da basicamente porque hiciste un cambio en un archivo que en el repositio cambio. Por ejemplo.

+ Editaste el Login.xaml
+ Alguien tambien lo edito y subio.
+ Al intentar subirlo o bajarlo la copia original tuya (sin tus cambios) no coincide con la actual en el repositorio.
+ Lo cual ocasiona conflictos con las versiones.


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



# MiCalculadora

Una calculadora portable desarrollada en C# con Windows Forms.

## Características

- Operaciones básicas: **suma, resta, multiplicación, división**
- Soporte para **números decimales**
- Botón **limpiar (C)** para reiniciar la calculadora
- **Manejo de errores** (división entre cero)
- Interfaz limpia y fácil de usar
- Ejecutable portable (.exe)

## Requisitos

- **.NET Framework 4.7.2** o superior
- Windows 7/8/10/11

## Cómo usar

### Opción 1: Descargar el ejecutable
1. Descarga el ejecutable desde la sección de Releases
2. Ejecuta `MiCalculadora.exe`
3. ¡Comienza a calcular!

### Opción 2: Compilar desde el código fuente

#### Usando Visual Studio
1. Abre `MiCalculadora.slnx` en Visual Studio 2022
2. Selecciona la configuración **Release**
3. Compila con **Build > Build Solution** (Ctrl+Shift+B)
4. El ejecutable estará en `MiCalculadora/bin/Release/MiCalculadora.exe`

#### Usando dotnet CLI
```bash
cd MiCalculadora
dotnet build -c Release
```

## Estructura del proyecto

```
MiCalculadora/
├── MiCalculadora/
│   ├── Form1.cs              # Lógica principal de la calculadora
│   ├── Form1.Designer.cs     # Diseño de la interfaz (generado)
│   ├── Form1.resx            # Recursos del formulario
│   ├── Program.cs            # Punto de entrada de la aplicación
│   ├── MiCalculadora.csproj  # Archivo de proyecto
│   ├── App.config            # Configuración de la aplicación
│   └── Properties/           # Propiedades del ensamblado
├── MiCalculadora.slnx        # Archivo de solución
└── README.md
```

## Tecnologías

- **C#** con .NET Framework 4.7.2
- **Windows Forms** para la interfaz gráfica
- **Visual Studio 2022**

## Licencia

Este proyecto es de uso educativo y personal.

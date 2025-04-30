# Simulación de Lanzamiento de Dados - Estadística y Probabilidad

Este es un proyecto de simulación de lanzamientos de dados desarrollado en C# con **Windows Forms**. El propósito del proyecto es simular el lanzamiento de dos dados, mostrar la suma de los resultados y calcular las frecuencias absolutas y relativas de las sumas. Los resultados se visualizan mediante gráficos y se actualizan en tiempo real mientras se realizan los lanzamientos.

## Funcionalidades

- **Simulación de Lanzamientos de Dados**: El usuario puede ingresar cuántas veces quiere realizar el lanzamiento de dos dados.
- **Gráficos de Frecuencia**: El proyecto genera dos gráficos:
  1. **Gráfico de Frecuencia Relativa**: Muestra la probabilidad acumulada de cada suma obtenida de los lanzamientos.
  2. **Gráfico de Frecuencia Absoluta**: Muestra la cantidad de veces que se ha obtenido cada suma.
- **Animación de los Dados**: Durante la simulación, se muestran imágenes de dados con los valores correspondientes a cada lanzamiento.
- **Tabla de Resultados**: La aplicación muestra una tabla con las frecuencias absolutas y relativas de las sumas obtenidas.

## Requisitos

- **.NET Framework 4.7.2 o superior**.
- **Visual Studio** o cualquier IDE compatible con C# y Windows Forms.
- **Biblioteca `System.Media`** para reproducir un sonido al girar los dados.

## Instrucciones de Uso

1. **Clonar el repositorio**:
2. 2. **Abrir el Proyecto**:
- Abre el proyecto en **Visual Studio** o cualquier otro IDE compatible con C#.

3. **Ejecutar la Aplicación**:
- Compila y ejecuta el proyecto desde el IDE.
- Aparecerá una ventana con el formulario para ingresar el número de lanzamientos de los dados.
- Ingresa el número de lanzamientos y haz clic en el botón para empezar la simulación.

4. **Ver los Resultados**:
- Durante la simulación, los resultados de cada tiro se mostrarán en tiempo real.
- Se actualizarán los gráficos de frecuencia y las tablas con los resultados obtenidos.

## Estructura del Proyecto

- **Form1.cs**: Contiene la lógica principal de la simulación, incluyendo el código para manejar los lanzamientos de los dados, actualizar los gráficos y mostrar los resultados.
- **Properties/Resources.resx**: Contiene los recursos del proyecto, como el sonido de los dados.


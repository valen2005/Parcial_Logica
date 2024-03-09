using System;

public class Program
{
    public static void Main()
    {
        // Definir la velocidad de cada tren en km/h
        int velocidadTren1 = 80;
        int velocidadTren2 = 100;

        // Definir el tiempo inicial de cada tren en horas
        double tiempoTren1 = 0;
        double tiempoTren2 = 1;

        // Definir el tiempo inicial de cada tren en horas
        double tiempoTren1 = 0; // El primer tren sale a las 10:00 AM
        double tiempoTren2 = 1; // El segundo tren sale una hora después, a las 11:00 AM

        // Calcular la distancia que recorre el primer tren durante la hora de diferencia
        double distanciaRecorridaTren1 = velocidadTren1 * tiempoTren2;

        // Calcular el tiempo que tarda el segundo tren en alcanzar al primer tren
        double tiempoAlcance = distanciaRecorridaTren1 / (velocidadTren2 - velocidadTren1);

        // Calcular la hora en que el segundo tren alcanza al primer tren
        double horaAlcance = 11 + tiempoAlcance;
    }


using System;

namespace Full_GRASP_And_SOLID.Library
{
    public class CalcularCostos
    {
    public static double Calcular(Step step)
    {
        double Insumos = step.Input.UnitCost * (step.Quantity / 1000);
        double Tiempo = step.Time;
        Tiempo = Tiempo / 3600;
        double Equipamiento = step.Equipment.HourlyCost * Tiempo;
        double SubTotal = Insumos + Equipamiento;
        return SubTotal;
    }
    // Para asignar esta responsabilidad se usa el SRP
    }
}

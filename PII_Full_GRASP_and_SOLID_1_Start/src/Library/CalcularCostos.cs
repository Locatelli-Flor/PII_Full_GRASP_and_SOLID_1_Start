using System;

public class CalcularCostos
{
    public static int Calcular(Step step)
    {
        int Insumos = step.input.unitCost;
        int Equipamiento = step.equipment.hourlyCost * step.time;
        int Subtotal = Insumos + Equipamiento;
        return Total;
    }
    // Para asignar esta responsabilidad se usa el SRP
}
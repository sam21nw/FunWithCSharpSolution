using System;

namespace canalLock;

public enum WaterLevel { Low, High }
public class CanalLock
{
    public WaterLevel CanalLockWaterLevel { get; private set; } = WaterLevel.Low;
    public bool HighWaterGateOpen { get; private set; } = false;
    public bool LowWaterGateOpen { get; private set; } = false;
    public void SetHighGate(bool open)
    {
        if (open && (CanalLockWaterLevel == WaterLevel.High))
            HighWaterGateOpen = true;
        else if (open && (CanalLockWaterLevel == WaterLevel.Low))
            throw new InvalidOperationException("Cannot open high gate when the water is low");
    }
    public void SetLowGate(bool open)
    {
        LowWaterGateOpen = open;
    }
    public void SetWaterLevel(WaterLevel newLevel)
    {
        CanalLockWaterLevel = newLevel;
    }
    public override string ToString() => $"The lower gate is {(LowWaterGateOpen ? "Open" : "Closed")}. " + $"The upper gate is {(HighWaterGateOpen ? "Open" : "Closed")}. " + $"The water level is {CanalLockWaterLevel}.";
}



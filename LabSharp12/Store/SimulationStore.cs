﻿using LabSharp11.Entities;

namespace LabSharp11.Store;

public class SimulationStore
{
    public required Company Company { get; init; }
    
    public required DateOnly Today { get; set; }
}
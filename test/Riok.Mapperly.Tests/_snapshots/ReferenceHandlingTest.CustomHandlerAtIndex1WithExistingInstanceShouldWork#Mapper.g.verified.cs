﻿//HintName: Mapper.g.cs
#nullable enable
public partial class Mapper
{
    private partial void Map(global::Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler, global::A a, global::B b)
    {
        b.Parent = MapToB(a.Parent, refHandler);
        b.Value = MapToD(a.Value, refHandler);
    }

    private global::B MapToB(global::A source, global::Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<global::A, global::B>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new global::B();
        refHandler.SetReference<global::A, global::B>(source, target);
        target.Parent = MapToB(source.Parent, refHandler);
        target.Value = MapToD(source.Value, refHandler);
        return target;
    }

    private global::D MapToD(global::C source, global::Riok.Mapperly.Abstractions.ReferenceHandling.IReferenceHandler refHandler)
    {
        if (refHandler.TryGetReference<global::C, global::D>(source, out var existingTargetReference))
            return existingTargetReference;
        var target = new global::D();
        refHandler.SetReference<global::C, global::D>(source, target);
        target.StringValue = source.StringValue;
        return target;
    }
}

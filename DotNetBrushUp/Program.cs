

/////////////////////////////
///Example 1: Finding Removable Artifacts Based on Dependencies

//var dependencies = new Dictionary<string, List<string>>
//{
//    ["Core.dll"] = new() { "Utils.dll" },
//    ["Legacy.dll"] = new() { "Utils.dll" }
//};

//var runtimeUsedArtifacts = new HashSet<string>
//{
//    "Core.dll",
//    "Utils.dll"
//};

//var allArtifacts = new HashSet<string>
//{
//    "Core.dll",
//    "Utils.dll",
//    "Legacy.dll",
//    "BuildHelper.exe"
//};

//GetRemovableArtifacts(dependencies, runtimeUsedArtifacts, allArtifacts);

//static HashSet<string> GetRemovableArtifacts(
//        IDictionary<string, List<string>> dependencies,
//        ISet<string> runtimeUsedArtifacts,
//        ISet<string> allArtifacts)
//{
//    // Keep = runtime-used + all their transitive dependencies
//    var keep = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
//    var stack = new Stack<string>(runtimeUsedArtifacts);

//    while (stack.Count > 0)
//    {
//        var artifact = stack.Pop();

//        // visited check handles cycles + prevents repeated work
//        if (!keep.Add(artifact))
//            continue;

//        if (dependencies.TryGetValue(artifact, out var deps))
//        {
//            foreach (var dep in deps)
//                stack.Push(dep);
//        }
//    }

//    // Removable = allArtifacts - keep
//    var removable = new HashSet<string>(allArtifacts, StringComparer.OrdinalIgnoreCase);
//    removable.ExceptWith(keep);

//    return removable;
//}


//////////////////////////
///Example 2: Using TryGetValue to Count Occurrences in a List

var counts = new Dictionary<string, int>();
var input = new List<string> { "apple", "banana", "apple", "orange", "banana", "apple" };


foreach (var s in input)
{
    counts[s] = counts.TryGetValue(s, out var c) ? c + 1 : 1;    
}

foreach (var (key, value) in counts)
{
    Console.WriteLine($"{key} has a value of {value}");
}





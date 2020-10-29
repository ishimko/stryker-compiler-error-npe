1. Clone the repo and checkout `master`.
2. `cd UnderTest.Tests`
3. `dotnet stryker --dashboard-compare --dashboard-version master --dashboard-fallback-version fake-fallback`
4. `git checkout another-branch`
5. `dotnet stryker --dashboard-compare --dashboard-version another-branch --dashboard-fallback-version dashboard-compare/master`
6. Observe exception
```
System.ArgumentNullException: Value cannot be null. (Parameter 'source')
   at System.Linq.ThrowHelper.ThrowArgumentNullException(ExceptionArgument argument)
   at System.Linq.Enumerable.Any[TSource](IEnumerable`1 source, Func`2 predicate)
   at Stryker.Core.MutantFilters.DiffMutantFilter.ResetMutantStatusForChangedTests(IEnumerable`1 mutants) in D:\a\1\s\src\Stryker.Core\Stryker.Core\MutantFilters\DiffMutantFilter.cs:line 261
   at Stryker.Core.MutantFilters.DiffMutantFilter.FilterMutants(IEnumerable`1 mutants, FileLeaf file, StrykerOptions options) in D:\a\1\s\src\Stryker.Core\Stryker.Core\MutantFilters\DiffMutantFilter.cs:line 109
   at Stryker.Core.MutantFilters.BroadcastMutantFilter.FilterMutants(IEnumerable`1 mutants, FileLeaf file, StrykerOptions options) in D:\a\1\s\src\Stryker.Core\Stryker.Core\MutantFilters\BroadcastMutantFilter.cs:line 43
   at Stryker.Core.MutationTest.MutationTestProcess.FilterMutants() in D:\a\1\s\src\Stryker.Core\Stryker.Core\MutationTest\MutationTestProcess.cs:line 285
   at Stryker.Core.StrykerRunner.RunMutationTest(StrykerOptions options, IEnumerable`1 initialLogMessages) in D:\a\1\s\src\Stryker.Core\Stryker.Core\StrykerRunner.cs:line 82
```

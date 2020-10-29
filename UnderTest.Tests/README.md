On another-branch: 
	`dotnet stryker --dashboard-compare --dashboard-version another-branch --dashboard-fallback-version dashboard-compare/master`
On master: 
	`dotnet stryker --dashboard-compare --dashboard-version master --dashboard-fallback-version fake-fallback`
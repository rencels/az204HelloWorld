var app = builder.Build();

app.UseForwardedHeaders(forwardedHeadersOptions);

// ❌ NO HTTPS REDIRECTION
// app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();

PanoptoAPITest notes
--------------------

This tool shows how to use cookie-based authentication with the Panopto PublicAPI.

Build steps:
- Open VS2010 solution
- In Solution Explorer, under Service References, select "Configure Service Reference" for both services
- Update Address field to point to the correct server, click OK.
- Edit app.config, ensure the following are set:
  - For all bindings, security mode attribute should be "Transport"
  - For all endpoints, there should be a behaviorConfiguration attribute set to "EnableCookieManager"
  - Endpoint URLs should reference "PublicAPI", not "PublicAPISSL", eg:
    - https://[servername]/Panopto/PublicAPI/4.0/Auth.svc
- Update user credentials passed to LogOnWithPassword() in Program.cs
- Build project


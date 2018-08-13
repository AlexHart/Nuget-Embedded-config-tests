# Nuget Embedded config
This solution is a proof of concept of how to embed configuration inside a nuget. For simplicity they are json files but stored as txt. It would be a matter of parsing. It could be xml or whatever.

The files can also be stored as binaries or whatever the user chooses, but then you have to read a byte[] with streams instead of just using a text file, which is usually used for configurations.

Of course **you should never store connection strings, passwords or anything sensitive unencrypted.**

In the **NugetProject** / Properties / Resources is where the configuration files are stored.

There is one project that consumes the dll (**DllConsumer**) and another one that consumes the nuget (**NugetConsumer**). Also the Nuget is calling to another dll with embedded resources inside.

## Remarks
> **NugetConsumer** only works if you add the nuget to a repository of your own, I used my local machine and didn't upload the nupkg to nuget.org because this is just a POC.

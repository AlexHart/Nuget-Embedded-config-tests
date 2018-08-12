# Nuget Embedded config
This solution is a proof of concept of how to embed configuration inside a nuget. For simplicity they are json files but stored as txt. It would be a matter of parsing. It could be xml or whatever.

The files can also be stored as binaries or whatever the user chooses, but then you have to read a byte[] with streams instead of just using a text file, which is usually used for configurations.

Of course **you should never store connection strings, passwords or anything sensitive unencrypted.**

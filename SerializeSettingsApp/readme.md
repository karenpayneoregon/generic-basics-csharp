# About

In this sample, we encrypt and decrypt a file using

- CommonLibrary, CryptoSerializer methods
    - Serialize(List&lt;T> list, Stream stream)
    - T DeserializeSingle(Stream stream) => Deserialize(stream).FirstOrDefault();

- [protobuf-net](https://github.com/protobuf-net/protobuf-net) to serialize and deserialize data while in this code sample CryptoSerializer methods first encrypt and decrypt the data.
- The file name in this case is in the application folder with a name of Common1Library so that a hacker will not be looking here for our data rather than name the file settings.bin for instance.

## Summary

Both CommonLibrary CryptoSerializer and protobuf-net work with any data generically.

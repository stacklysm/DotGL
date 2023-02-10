// These global aliases are used to simplify the code that gets and sets uniforms.
// OpenTK doesn't support uvecn and bvecn types, so we use the second best thing: value tuples!

global using Vector2b = System.ValueTuple<bool, bool>;
global using Vector2ui = System.ValueTuple<uint, uint>;
global using Vector3b = System.ValueTuple<bool, bool, bool>;
global using Vector3ui = System.ValueTuple<uint, uint, uint>;
global using Vector4b = System.ValueTuple<bool, bool, bool, bool>;
global using Vector4ui = System.ValueTuple<uint, uint, uint, uint>;

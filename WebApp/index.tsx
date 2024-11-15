import React, { StrictMode } from "react";
import { createRoot } from "react-dom/client";
import { hello } from "../FunctionalCore/Library.fs.ts"
import { User } from "../FunctionalCore/User.fs.ts"

export const App = () => {
  const user = new User("Alice", 42);
  const message = hello(user.Name);
  return <h1>{ message }</h1>;
};

const rootElement = document.getElementById("root");

if (!rootElement) {
  throw new Error("Root element not found");
}

const root = createRoot(rootElement);

root.render(
  <StrictMode>
    <App />
  </StrictMode>
);
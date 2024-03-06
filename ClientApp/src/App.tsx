import React from "react";
import AppRoutes from "./AppRoutes";
import "./custom.css";
import { Route, Routes } from "react-router-dom";

export const App: React.FC = () => {
  return (
    <>
      <Routes>
        {AppRoutes.map((route, index) => {
          const { element, ...rest } = route;
          return <Route key={index} {...rest} element={element} />;
        })}
      </Routes>
    </>
  );
};

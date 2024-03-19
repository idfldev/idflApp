import { Route, Routes } from "react-router-dom";
import { Layout } from "./Layout/Layout";
import { LandingPageRoutes } from "Routes/LandingPageRoutes";
export const LandingPageApp = () => {
  return (
    <>
      <Routes>
        {LandingPageRoutes.map((route, index) => {
          const { element, ...rest } = route;
          return <Route key={index} {...rest} element={element} />;
        })}
      </Routes>
    </>
  );
};

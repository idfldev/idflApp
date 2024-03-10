import { Route, Routes } from "react-router-dom";
import { LayoutManagement } from "./Layout/layout-management";
import { ManagementRoutes } from "Routes/ManagementRoutes";

export const ManagementApp = () => {
  return (
    <>
      <LayoutManagement>
        <Routes>
          {ManagementRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
        </Routes>
      </LayoutManagement>
    </>
  );
};

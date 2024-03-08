import { Route, Routes } from "react-router-dom";
import { LayoutManagement } from "./layout-management";
import AppRoutes from "AppRoutes";

export const ManagementApp = () => {
  return (
    <>
      <LayoutManagement>
        <Routes>
          {AppRoutes.map((route, index) => {
            const { element, ...rest } = route;
            return <Route key={index} {...rest} element={element} />;
          })}
        </Routes>
      </LayoutManagement>
    </>
  );
};

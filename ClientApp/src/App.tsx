import React from "react";
import AppRoutes from "./AppRoutes";
import "./custom.css";
import { BookCreateForm } from "components/Pages/Management/Project-components/Project/book-create-form";
import { Route, Routes, useParams } from "react-router-dom";
import { LoginApp } from "components/Pages/Management/Login/login";
import { LayoutManagement } from "components/Pages/Management/layout-management";
import { ManagementApp } from "components/Pages/Management";

export const App: React.FC = () => {
  return (
    <>
      <Routes>
        <Route path="/management/*" element={<ManagementApp />}/>
        <Route path="/" element={<LoginApp />} />
      </Routes>
    </>
  );
};

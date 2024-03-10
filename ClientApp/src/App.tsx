import React from "react";
import "./custom.css";
import {  Route, Routes } from "react-router-dom";
import { LoginApp } from "components/Pages/Management/Login/login";
import { ManagementApp } from "components/Pages/Management";

export const App: React.FC = () => {
  return (
    <>
      <Routes>
        <Route path="/management/*" element={<ManagementApp />} />
        <Route path="/" element={<LoginApp />} />
      </Routes>
    </>
  );
};

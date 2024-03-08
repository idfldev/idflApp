import React from "react";
import AppRoutes from "./AppRoutes";
import "./custom.css";
import { BookCreateForm } from "components/Pages/Management/Project-components/Project/book-create-form";
import { Route, Routes, useParams } from "react-router-dom";

export const App: React.FC = () => {
  const BookCreateRoute = () => {
    const { id } = useParams(); // Get id from route params
    return <BookCreateForm projectId={id} />;
  };
  return (
    <>
      <Routes>
        {AppRoutes.map((route, index) => {
          const { element, ...rest } = route;
          return <Route key={index} {...rest} element={element} />;
        })}
        <Route
          path="/management-dashboard/book-create/:id"
          element={<BookCreateRoute />}
        />
      </Routes>
    </>
  );
};

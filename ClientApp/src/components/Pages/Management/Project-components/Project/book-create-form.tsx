import { Combobox, Transition } from "@headlessui/react";
import { CheckIcon, ChevronUpDownIcon } from "@heroicons/react/24/solid";
import axios from "axios";
import { Fragment, useEffect, useState } from "react";
import Datepicker from "react-tailwindcss-datepicker";
import { LayoutManagement } from "../../layout-management";
import React from "react";
import "./book-create-form.css";
import { useNavigate } from "react-router";
interface BookCreateInterface {
  projectId: any;
}
interface AuditorInferface {
  id: any;
  name: any;
}
export const BookCreateForm: React.FC<BookCreateInterface> = (props) => {
  const navigate = useNavigate();
  const [errorAlert, setErrorAlert] = useState("");
  const [client, setClient] = useState("");
  const [standard, setStandard] = useState("");
  const [status, setStatus] = useState("");
  const [auditors, setAuditors] = useState<AuditorInferface[]>([] || null);
  const [purpose, setPurpose] = useState();
  const [description, setDescription] = useState();
  const [startDate, setStartDate] = useState({
    startDate: null,
    endDate: null, // Convert the result to a Date object
  });
  const [endDate, setEndDate] = useState({
    startDate: null,
    endDate: null, // Convert the result to a Date object
  });
  const [selected, setSelected] = useState(auditors[0]);
  const [error, setError] = useState<string | null>(null);
  const [query, setQuery] = useState("");
  var token =
    "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6ImYzNjJiMTc0LWUyNzUtNGIxZi1iMTYwLTZjNWEzNWFmOWRlOCIsIm5iZiI6MTcwOTg5NDI0NywiZXhwIjoxNzA5ODk2MDQ3LCJpYXQiOjE3MDk4OTQyNDd9.1SV0HnvrVLp5j0TrbW4bve3p23AS9dm78SbiybChFHU";
  const getDataFromBook = async () => {
    try {
      const response = await axios.get(
        `api/management/book/${props.projectId}`,
        {
          headers: {
            Authorization: token,
          },
        }
      );
      // Handle the response data here
      setClient(response.data.client);
      setStandard(response.data.standard);
      setStatus(response.data.status);
      setAuditors(response.data.auditors);
    } catch (error) {
      // Handle any errors that occur during the request
      console.error("Error fetching data:", error);
    }
  };

  const filteredPeople =
    query === ""
      ? auditors
      : auditors.filter((person: any) =>
          person.name
            .toLowerCase()
            .replace(/\s+/g, "")
            .includes(query.toLowerCase().replace(/\s+/g, ""))
        );

  const handlePurposeChange = (event: any) => {
    setPurpose(event.target.value);
  };
  const handleDescriptionChange = (event: any) => {
    setDescription(event.target.value);
  };
  const handleEndDateChange = (event: any) => {
    setEndDate(event);
  };
  const handleStartDateChange = (event: any) => {
    setStartDate(event);
  };
  const handleSubmit = async (event: any) => {
    event.preventDefault();
    const requiredFields = [];

    if (!purpose) {
      requiredFields.push("Booking Purpose");
    }
    if (!startDate?.startDate) {
      requiredFields.push("Start Date");
    }
    if (!endDate?.endDate) {
      requiredFields.push("End Date");
    }
    if (requiredFields.length > 0) {
      const emptyFieldsMessage = `Error Empty fields: ${requiredFields.join(
        ", "
      )}.`;
      setError(emptyFieldsMessage);
      setErrorAlert("modal-error-active");
      return;
    }
    const formData = {
      projectId: props.projectId,
      AuditBy: selected?.id,
      Purpose: purpose,
      StartedAt: startDate.startDate,
      EndedAt: endDate.endDate,
      Description: description,
    };

    try {
      const response = await axios.post("api/management/book", formData, {
        headers: {
          Authorization: token,
        },
      });
      // window.location.reload();
      navigate("/management-dashboard");
    } catch (error: any) {
      console.error("Error adding data:", error);
      const errorMessage = error.response.data.message;
      setError(errorMessage);
    }
  };
  useEffect(() => {
    getDataFromBook();

    const timer = setTimeout(() => {
      setErrorAlert(""); // Hide the error alert after 3 seconds
    }, 3000);
    return () => clearTimeout(timer);
  }, [errorAlert]);
  return (
    <>
      <LayoutManagement>
        <form onSubmit={handleSubmit} className="p-3">
          <div className="space-y-0 p-5 m-auto relative w-4/6">
            <div className="pb-0">
              <h1 className="text-base font-semibold leading-7 text-gray-900">
                BOOKING
              </h1>
              <h5>{standard}</h5>
              <h6>{client}</h6>
              <h6>{status}</h6>
              <div className="mt-10 grid grid-cols-12 gap-x-6 gap-y-8">
                <div className="col-span-12">
                  <label
                    htmlFor="name"
                    className="block text-sm font-medium leading-6 text-gray-900"
                  >
                    Booking Purpose
                  </label>
                  <div className="mt-2">
                    <input
                      value={purpose}
                      onChange={handlePurposeChange}
                      type="text"
                      name="name"
                      id="name"
                      autoComplete="family-name"
                      className="border p-2 w-full"
                    />
                  </div>
                </div>
                <div className="col-span-12">
                  <label
                    htmlFor="audit"
                    className="block text-sm font-medium leading-6 text-gray-900"
                  >
                    Auditer on duty
                  </label>

                  <div className="col-span-12">
                    <Combobox value={selected || ""} onChange={setSelected}>
                      <div className="relative mt-1">
                        <div className="relative w-full cursor-default overflow-hidden border  bg-white text-left focus:outline-none focus-visible:ring-2 focus-visible:ring-white/75 focus-visible:ring-offset-2 focus-visible:ring-offset-teal-300 sm:text-sm">
                          <Combobox.Input
                            className="w-full border-none py-2 pl-3 pr-10 text-sm leading-5 text-gray-900 focus:ring-0"
                            displayValue={(person: any) => person.name}
                            onChange={(event) => setQuery(event.target.value)}
                          />
                          <Combobox.Button className="absolute inset-y-0 right-0 flex items-center pr-2">
                            <ChevronUpDownIcon
                              className="h-5 w-5 text-gray-400"
                              aria-hidden="true"
                            />
                          </Combobox.Button>
                        </div>
                        <Transition
                          as={Fragment}
                          leave="transition ease-in duration-100"
                          leaveFrom="opacity-100"
                          leaveTo="opacity-0"
                          afterLeave={() => setQuery("")}
                        >
                          <Combobox.Options className="absolute z-10 mt-1 max-h-60 w-full overflow-auto rounded-md bg-white py-1 text-base shadow-lg ring-1 ring-black/5 focus:outline-none sm:text-sm">
                            {filteredPeople.length === 0 && query !== "" ? (
                              <div className="relative cursor-default select-none px-4 py-2 text-gray-700">
                                Nothing found.
                              </div>
                            ) : (
                              filteredPeople.map((person: any) => (
                                <Combobox.Option
                                  key={person.id}
                                  className={({ active }) =>
                                    `relative cursor-default select-none py-2 pl-10 pr-4 ${
                                      active
                                        ? "bg-teal-600 text-white"
                                        : "text-gray-900"
                                    }`
                                  }
                                  value={person}
                                >
                                  {({ selected, active }) => (
                                    <>
                                      <span
                                        className={`block truncate ${
                                          selected
                                            ? "font-medium"
                                            : "font-normal"
                                        }`}
                                      >
                                        {person.name}
                                      </span>
                                      {selected ? (
                                        <span
                                          className={`absolute inset-y-0 left-0 flex items-center pl-3 ${
                                            active
                                              ? "text-white"
                                              : "text-teal-600"
                                          }`}
                                        >
                                          <CheckIcon
                                            className="h-5 w-5"
                                            aria-hidden="true"
                                          />
                                        </span>
                                      ) : null}
                                    </>
                                  )}
                                </Combobox.Option>
                              ))
                            )}
                          </Combobox.Options>
                        </Transition>
                      </div>
                    </Combobox>
                  </div>
                </div>
                <div className="col-span-6">
                  <label
                    htmlFor="start-date"
                    className="block text-sm font-medium leading-6 text-gray-900"
                  >
                    Start Date
                  </label>
                  <div className="border">
                    <Datepicker
                      useRange={false}
                      asSingle={true}
                      value={startDate}
                      onChange={handleStartDateChange}
                    />
                  </div>
                </div>
                <div className="col-span-6">
                  <label
                    htmlFor="postal-code"
                    className="block text-sm font-medium leading-6 text-gray-900"
                  >
                    End Date
                  </label>
                  <div className="border">
                    <Datepicker
                      useRange={false}
                      asSingle={true}
                      value={endDate}
                      onChange={handleEndDateChange}
                    />
                  </div>
                </div>
                <div className="col-span-12">
                  <label
                    htmlFor="region"
                    className="block text-sm font-medium leading-6 text-gray-900"
                  >
                    Description
                  </label>
                  <div className="mt-2">
                    <textarea
                      value={description}
                      onChange={handleDescriptionChange}
                      name="region"
                      id="region"
                      rows={3}
                      autoComplete="address-level1"
                      className="border w-full p-2"
                    ></textarea>
                  </div>

                  <div className={`modal-error  p-3 text-white ${errorAlert}`}>
                    <div className="modal-content">
                      <p>{error}</p>
                    </div>
                  </div>
                </div>
                <button
                  type="submit"
                  className="bg-blue-500 hover:bg-blue-700 col-span-6 text-white font-bold py-2 px-4 rounded mt-2"
                >
                  Submit
                </button>
              </div>
            </div>
          </div>
        </form>
      </LayoutManagement>
    </>
  );
};
export default React.memo(BookCreateForm);

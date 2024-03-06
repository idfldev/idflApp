import { Combobox, Transition } from "@headlessui/react";
import { CheckIcon, ChevronUpDownIcon } from "@heroicons/react/24/solid";
import { Fragment, useEffect, useState } from "react";
import Datepicker from "react-tailwindcss-datepicker";
interface BookModal {
  projectId: any;
  standard: any;
  client: any;
  users:any
}
export const BookForm: React.FC<BookModal> = (props) => {
  const [name, setName] = useState();
  const [value, setValue] = useState({
    startDate: null,
    endDate: null, // Convert the result to a Date object
  });
  console.log("users:", props.users);
  const [selected, setSelected] = useState(props.users[0]);
  const [query, setQuery] = useState("");

  const filteredPeople =
    query === ""
      ? props.users
      : props.users.filter((person:any) =>
          person.name
            .toLowerCase()
            .replace(/\s+/g, "")
            .includes(query.toLowerCase().replace(/\s+/g, ""))
        );
  const handleInputChange = (event: any) => {
    setName(event.target.value);
    console.log(event.target.value);
  };
  const handleValueChange = (newValue: any) => {
    console.log("newValue:", newValue);
    setValue(newValue);
  };
  const handleSubmit = async (event: any) => {
    event.preventDefault(); // Prevents the default form submission behavior
    alert(selected.id + "-" + name);
  };
  return (
    <>
      <form onSubmit={handleSubmit}>
        <div className="space-y-0 p-5 w-full m-auto relative">
          <div className="pb-0">
            <h1 className="text-base font-semibold leading-7 text-gray-900">
              BOOKING
            </h1>
            <h5>{props.standard}</h5>
            <h6>{props.client}</h6>
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
                    value={name}
                    onChange={handleInputChange}
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
                  <Combobox value={selected} onChange={setSelected}>
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
                                        selected ? "font-medium" : "font-normal"
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
                    value={value}
                    onChange={handleValueChange}
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
                    value={value}
                    onChange={handleValueChange}
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
                    name="region"
                    id="region"
                    rows={3}
                    autoComplete="address-level1"
                    className="border w-full p-2"
                  ></textarea>
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
    </>
  );
};

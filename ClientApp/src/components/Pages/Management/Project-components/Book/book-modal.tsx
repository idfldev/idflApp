import { Dialog, Transition } from "@headlessui/react";
import { Fragment } from "react/jsx-runtime";
import { useRef } from "react";
import { BookForm } from "./book-form";
interface projectInterface {
  open: any;
  setOpen: any;
  projectId: any;
  standard: any;
  client: any;
  users:any
}
export const BookModal: React.FC<projectInterface> = (props) => {
  return (
    <>
      <Transition.Root show={props.open} as={Fragment}>
        <Dialog
          as="div"
          className="relative z-10"
          onClose={props.setOpen}
        >
          <Transition.Child
            as={Fragment}
            enter="ease-out duration-300"
            enterFrom="opacity-0"
            enterTo="opacity-100"
            leave="ease-in duration-200"
            leaveFrom="opacity-100"
            leaveTo="opacity-0"
          >
            <div className="fixed  inset-0 bg-gray-500 bg-opacity-75 transition-opacity" />
          </Transition.Child>

          <div className="fixed inset-0 z-10 w-screen overflow-y-auto ">
            <div className="flex min-h-full items-end justify-center p-4 text-center sm:items-center sm:p-0">
              <Transition.Child
                as={Fragment}
                enter="ease-out duration-300"
                enterFrom="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
                enterTo="opacity-100 translate-y-0 sm:scale-100"
                leave="ease-in duration-200"
                leaveFrom="opacity-100 translate-y-0 sm:scale-100"
                leaveTo="opacity-0 translate-y-4 sm:translate-y-0 sm:scale-95"
              >
                <Dialog.Panel className="w-full max-w-2xl rounded bg-white relative">
                  <div className="bg-white text-left px-4 pb-4 pt-5 sm:p-6 sm:pb-4">
                    <BookForm
                      projectId={props.projectId}
                      standard={props.standard}
                      client={props.client}
                      users = {props.users}
                    />
                    <div className=" sm:flex-row-reverse sm:px-6 absolute top-4 right-0">
                      <button
                        type="button"
                        className="mt-3 inline-flex w-full justify-center rounded-md px-3 py-2 text-sm font-semibold text-gray-600   hover:bg-gray-50 sm:mt-0 sm:w-auto"
                        onClick={() => props.setOpen(false)}
                      >
                        X
                      </button>
                    </div>
                  </div>
                </Dialog.Panel>
              </Transition.Child>
            </div>
          </div>
        </Dialog>
      </Transition.Root>
    </>
  );
};

export class Driver {

    public constructor(
        public id: string,
        public firstName: string,
        public lastName: string,
        public phoneNumber: string,
        public startWorkingDate: Date,
        public checkWorkingDate: Date,
        public address: string,
        public email: string
    ) { }

}
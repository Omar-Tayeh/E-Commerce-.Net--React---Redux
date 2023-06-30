import * as yup from 'yup';

export const validationSchema = [
    yup.object({
        fullName: yup.string().required('Full Name is Required'),
        address1: yup.string().required('Address line 1 is Required'),
        address2: yup.string().required(),
        city: yup.string().required(),
        province: yup.string().required(),
        postCode: yup.string().required(),
        country: yup.string().required()
    }),
    yup.object(),
    yup.object({
        nameOnCard: yup.string().required()
    })
]